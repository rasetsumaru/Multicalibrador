<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Multicalibrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Multicalibrador))
        Me.TrackBarControl = New System.Windows.Forms.TrackBar()
        Me.RadioButton0003 = New System.Windows.Forms.RadioButton()
        Me.RadioButton0004 = New System.Windows.Forms.RadioButton()
        Me.RadioButton0005 = New System.Windows.Forms.RadioButton()
        Me.GroupBoxOutput = New System.Windows.Forms.GroupBox()
        Me.AquaGaugeControlOutput = New AquaControls.AquaGauge()
        Me.GroupBoxInput = New System.Windows.Forms.GroupBox()
        Me.RadioButton0000 = New System.Windows.Forms.RadioButton()
        Me.RadioButton0002 = New System.Windows.Forms.RadioButton()
        Me.RadioButton0001 = New System.Windows.Forms.RadioButton()
        Me.AquaGaugeControlInput = New AquaControls.AquaGauge()
        Me.TextBoxReceiver = New System.Windows.Forms.TextBox()
        Me.Label0000 = New System.Windows.Forms.Label()
        Me.Label0001 = New System.Windows.Forms.Label()
        Me.Panel0000 = New System.Windows.Forms.Panel()
        Me.ButtonDisconnect = New System.Windows.Forms.Button()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.LabelHour = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.PanelRx = New System.Windows.Forms.Panel()
        Me.PanelTx = New System.Windows.Forms.Panel()
        Me.Label0002 = New System.Windows.Forms.Label()
        Me.Label0003 = New System.Windows.Forms.Label()
        Me.TextBoxSend = New System.Windows.Forms.TextBox()
        CType(Me.TrackBarControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOutput.SuspendLayout()
        Me.GroupBoxInput.SuspendLayout()
        Me.Panel0000.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrackBarControl
        '
        Me.TrackBarControl.Location = New System.Drawing.Point(421, 263)
        Me.TrackBarControl.Name = "TrackBarControl"
        Me.TrackBarControl.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBarControl.Size = New System.Drawing.Size(45, 185)
        Me.TrackBarControl.TabIndex = 144
        Me.TrackBarControl.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'RadioButton0003
        '
        Me.RadioButton0003.AutoSize = True
        Me.RadioButton0003.Location = New System.Drawing.Point(13, 19)
        Me.RadioButton0003.Name = "RadioButton0003"
        Me.RadioButton0003.Size = New System.Drawing.Size(92, 17)
        Me.RadioButton0003.TabIndex = 146
        Me.RadioButton0003.TabStop = True
        Me.RadioButton0003.Text = "Voltage 0-10V"
        Me.RadioButton0003.UseVisualStyleBackColor = True
        '
        'RadioButton0004
        '
        Me.RadioButton0004.AutoSize = True
        Me.RadioButton0004.Location = New System.Drawing.Point(13, 42)
        Me.RadioButton0004.Name = "RadioButton0004"
        Me.RadioButton0004.Size = New System.Drawing.Size(98, 17)
        Me.RadioButton0004.TabIndex = 147
        Me.RadioButton0004.TabStop = True
        Me.RadioButton0004.Text = "Current 0-20mA"
        Me.RadioButton0004.UseVisualStyleBackColor = True
        '
        'RadioButton0005
        '
        Me.RadioButton0005.AutoSize = True
        Me.RadioButton0005.Location = New System.Drawing.Point(13, 65)
        Me.RadioButton0005.Name = "RadioButton0005"
        Me.RadioButton0005.Size = New System.Drawing.Size(124, 17)
        Me.RadioButton0005.TabIndex = 148
        Me.RadioButton0005.TabStop = True
        Me.RadioButton0005.Text = "Thermocouple type J"
        Me.RadioButton0005.UseVisualStyleBackColor = True
        '
        'GroupBoxOutput
        '
        Me.GroupBoxOutput.Controls.Add(Me.RadioButton0003)
        Me.GroupBoxOutput.Controls.Add(Me.RadioButton0005)
        Me.GroupBoxOutput.Controls.Add(Me.RadioButton0004)
        Me.GroupBoxOutput.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBoxOutput.Location = New System.Drawing.Point(25, 250)
        Me.GroupBoxOutput.Name = "GroupBoxOutput"
        Me.GroupBoxOutput.Size = New System.Drawing.Size(157, 94)
        Me.GroupBoxOutput.TabIndex = 149
        Me.GroupBoxOutput.TabStop = False
        Me.GroupBoxOutput.Text = "Output select"
        '
        'AquaGaugeControlOutput
        '
        Me.AquaGaugeControlOutput.BackColor = System.Drawing.Color.Transparent
        Me.AquaGaugeControlOutput.DialColor = System.Drawing.Color.DarkGray
        Me.AquaGaugeControlOutput.DialText = "Control"
        Me.AquaGaugeControlOutput.Glossiness = 1.0!
        Me.AquaGaugeControlOutput.Location = New System.Drawing.Point(211, 263)
        Me.AquaGaugeControlOutput.MaxValue = 10.0!
        Me.AquaGaugeControlOutput.MinValue = 0.0!
        Me.AquaGaugeControlOutput.Name = "AquaGaugeControlOutput"
        Me.AquaGaugeControlOutput.NoOfDivisions = 5
        Me.AquaGaugeControlOutput.NoOfSubDivisions = 1
        Me.AquaGaugeControlOutput.RecommendedValue = 1.0!
        Me.AquaGaugeControlOutput.Size = New System.Drawing.Size(185, 185)
        Me.AquaGaugeControlOutput.TabIndex = 143
        Me.AquaGaugeControlOutput.ThresholdPercent = 1.0!
        Me.AquaGaugeControlOutput.Value = 0.0!
        '
        'GroupBoxInput
        '
        Me.GroupBoxInput.Controls.Add(Me.RadioButton0000)
        Me.GroupBoxInput.Controls.Add(Me.RadioButton0002)
        Me.GroupBoxInput.Controls.Add(Me.RadioButton0001)
        Me.GroupBoxInput.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBoxInput.Location = New System.Drawing.Point(109, 96)
        Me.GroupBoxInput.Name = "GroupBoxInput"
        Me.GroupBoxInput.Size = New System.Drawing.Size(157, 94)
        Me.GroupBoxInput.TabIndex = 150
        Me.GroupBoxInput.TabStop = False
        Me.GroupBoxInput.Text = "Input select"
        '
        'RadioButton0000
        '
        Me.RadioButton0000.AutoSize = True
        Me.RadioButton0000.Location = New System.Drawing.Point(13, 19)
        Me.RadioButton0000.Name = "RadioButton0000"
        Me.RadioButton0000.Size = New System.Drawing.Size(92, 17)
        Me.RadioButton0000.TabIndex = 146
        Me.RadioButton0000.TabStop = True
        Me.RadioButton0000.Text = "Voltage 0-10V"
        Me.RadioButton0000.UseVisualStyleBackColor = True
        '
        'RadioButton0002
        '
        Me.RadioButton0002.AutoSize = True
        Me.RadioButton0002.Location = New System.Drawing.Point(13, 65)
        Me.RadioButton0002.Name = "RadioButton0002"
        Me.RadioButton0002.Size = New System.Drawing.Size(124, 17)
        Me.RadioButton0002.TabIndex = 148
        Me.RadioButton0002.TabStop = True
        Me.RadioButton0002.Text = "Thermocouple type J"
        Me.RadioButton0002.UseVisualStyleBackColor = True
        '
        'RadioButton0001
        '
        Me.RadioButton0001.AutoSize = True
        Me.RadioButton0001.Location = New System.Drawing.Point(13, 42)
        Me.RadioButton0001.Name = "RadioButton0001"
        Me.RadioButton0001.Size = New System.Drawing.Size(98, 17)
        Me.RadioButton0001.TabIndex = 147
        Me.RadioButton0001.TabStop = True
        Me.RadioButton0001.Text = "Current 0-20mA"
        Me.RadioButton0001.UseVisualStyleBackColor = True
        '
        'AquaGaugeControlInput
        '
        Me.AquaGaugeControlInput.BackColor = System.Drawing.Color.Transparent
        Me.AquaGaugeControlInput.DialColor = System.Drawing.Color.DarkGray
        Me.AquaGaugeControlInput.DialText = "Control"
        Me.AquaGaugeControlInput.Glossiness = 1.0!
        Me.AquaGaugeControlInput.Location = New System.Drawing.Point(295, 59)
        Me.AquaGaugeControlInput.MaxValue = 10.0!
        Me.AquaGaugeControlInput.MinValue = 0.0!
        Me.AquaGaugeControlInput.Name = "AquaGaugeControlInput"
        Me.AquaGaugeControlInput.NoOfDivisions = 5
        Me.AquaGaugeControlInput.NoOfSubDivisions = 1
        Me.AquaGaugeControlInput.RecommendedValue = 1.0!
        Me.AquaGaugeControlInput.Size = New System.Drawing.Size(185, 185)
        Me.AquaGaugeControlInput.TabIndex = 151
        Me.AquaGaugeControlInput.ThresholdPercent = 1.0!
        Me.AquaGaugeControlInput.Value = 0.0!
        '
        'TextBoxReceiver
        '
        Me.TextBoxReceiver.Location = New System.Drawing.Point(25, 196)
        Me.TextBoxReceiver.Name = "TextBoxReceiver"
        Me.TextBoxReceiver.Size = New System.Drawing.Size(17, 20)
        Me.TextBoxReceiver.TabIndex = 152
        Me.TextBoxReceiver.Visible = False
        '
        'Label0000
        '
        Me.Label0000.AutoSize = True
        Me.Label0000.Font = New System.Drawing.Font("Arial Unicode MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label0000.ForeColor = System.Drawing.Color.White
        Me.Label0000.Location = New System.Drawing.Point(9, 9)
        Me.Label0000.Name = "Label0000"
        Me.Label0000.Size = New System.Drawing.Size(204, 39)
        Me.Label0000.TabIndex = 154
        Me.Label0000.Text = "Multicalibrador"
        '
        'Label0001
        '
        Me.Label0001.AutoSize = True
        Me.Label0001.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label0001.ForeColor = System.Drawing.Color.White
        Me.Label0001.Location = New System.Drawing.Point(14, 48)
        Me.Label0001.Name = "Label0001"
        Me.Label0001.Size = New System.Drawing.Size(72, 21)
        Me.Label0001.TabIndex = 155
        Me.Label0001.Text = "Interface"
        '
        'Panel0000
        '
        Me.Panel0000.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel0000.Controls.Add(Me.ButtonDisconnect)
        Me.Panel0000.Controls.Add(Me.ButtonConnect)
        Me.Panel0000.Controls.Add(Me.LabelHour)
        Me.Panel0000.Controls.Add(Me.ButtonClose)
        Me.Panel0000.Location = New System.Drawing.Point(-1, 476)
        Me.Panel0000.Name = "Panel0000"
        Me.Panel0000.Size = New System.Drawing.Size(497, 83)
        Me.Panel0000.TabIndex = 156
        '
        'ButtonDisconnect
        '
        Me.ButtonDisconnect.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDisconnect.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonDisconnect.Location = New System.Drawing.Point(295, 46)
        Me.ButtonDisconnect.Name = "ButtonDisconnect"
        Me.ButtonDisconnect.Size = New System.Drawing.Size(90, 26)
        Me.ButtonDisconnect.TabIndex = 36
        Me.ButtonDisconnect.TabStop = False
        Me.ButtonDisconnect.Text = "Disconnect"
        Me.ButtonDisconnect.UseVisualStyleBackColor = True
        '
        'ButtonConnect
        '
        Me.ButtonConnect.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonConnect.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnect.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonConnect.Location = New System.Drawing.Point(295, 46)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(90, 26)
        Me.ButtonConnect.TabIndex = 35
        Me.ButtonConnect.TabStop = False
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'LabelHour
        '
        Me.LabelHour.AutoSize = True
        Me.LabelHour.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelHour.Location = New System.Drawing.Point(14, 59)
        Me.LabelHour.Name = "LabelHour"
        Me.LabelHour.Size = New System.Drawing.Size(49, 13)
        Me.LabelHour.TabIndex = 34
        Me.LabelHour.Text = "00:00:00"
        '
        'ButtonClose
        '
        Me.ButtonClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonClose.Location = New System.Drawing.Point(391, 46)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(90, 26)
        Me.ButtonClose.TabIndex = 4
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'PanelRx
        '
        Me.PanelRx.BackColor = System.Drawing.Color.Transparent
        Me.PanelRx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelRx.Location = New System.Drawing.Point(25, 429)
        Me.PanelRx.Name = "PanelRx"
        Me.PanelRx.Size = New System.Drawing.Size(15, 15)
        Me.PanelRx.TabIndex = 160
        '
        'PanelTx
        '
        Me.PanelTx.BackColor = System.Drawing.Color.Transparent
        Me.PanelTx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelTx.Location = New System.Drawing.Point(25, 403)
        Me.PanelTx.Name = "PanelTx"
        Me.PanelTx.Size = New System.Drawing.Size(15, 15)
        Me.PanelTx.TabIndex = 159
        '
        'Label0002
        '
        Me.Label0002.AutoSize = True
        Me.Label0002.ForeColor = System.Drawing.SystemColors.Control
        Me.Label0002.Location = New System.Drawing.Point(51, 403)
        Me.Label0002.Name = "Label0002"
        Me.Label0002.Size = New System.Drawing.Size(44, 13)
        Me.Label0002.TabIndex = 157
        Me.Label0002.Text = "USB Tx"
        '
        'Label0003
        '
        Me.Label0003.AutoSize = True
        Me.Label0003.ForeColor = System.Drawing.SystemColors.Control
        Me.Label0003.Location = New System.Drawing.Point(51, 429)
        Me.Label0003.Name = "Label0003"
        Me.Label0003.Size = New System.Drawing.Size(45, 13)
        Me.Label0003.TabIndex = 158
        Me.Label0003.Text = "USB Rx"
        '
        'TextBoxSend
        '
        Me.TextBoxSend.Location = New System.Drawing.Point(25, 170)
        Me.TextBoxSend.Name = "TextBoxSend"
        Me.TextBoxSend.Size = New System.Drawing.Size(17, 20)
        Me.TextBoxSend.TabIndex = 145
        Me.TextBoxSend.Visible = False
        '
        'Form_Multicalibrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(495, 558)
        Me.Controls.Add(Me.PanelRx)
        Me.Controls.Add(Me.PanelTx)
        Me.Controls.Add(Me.Label0002)
        Me.Controls.Add(Me.Label0003)
        Me.Controls.Add(Me.Panel0000)
        Me.Controls.Add(Me.Label0001)
        Me.Controls.Add(Me.Label0000)
        Me.Controls.Add(Me.AquaGaugeControlInput)
        Me.Controls.Add(Me.TextBoxReceiver)
        Me.Controls.Add(Me.GroupBoxInput)
        Me.Controls.Add(Me.GroupBoxOutput)
        Me.Controls.Add(Me.TextBoxSend)
        Me.Controls.Add(Me.TrackBarControl)
        Me.Controls.Add(Me.AquaGaugeControlOutput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Multicalibrador"
        Me.Opacity = 0.90000000000000002R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multicalibrador Interface"
        Me.TransparencyKey = System.Drawing.Color.LavenderBlush
        CType(Me.TrackBarControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOutput.ResumeLayout(False)
        Me.GroupBoxOutput.PerformLayout()
        Me.GroupBoxInput.ResumeLayout(False)
        Me.GroupBoxInput.PerformLayout()
        Me.Panel0000.ResumeLayout(False)
        Me.Panel0000.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrackBarControl As System.Windows.Forms.TrackBar
    Friend WithEvents RadioButton0003 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton0004 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton0005 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBoxOutput As System.Windows.Forms.GroupBox
    Friend WithEvents AquaGaugeControlOutput As AquaControls.AquaGauge
    Friend WithEvents GroupBoxInput As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton0000 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton0002 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton0001 As System.Windows.Forms.RadioButton
    Friend WithEvents AquaGaugeControlInput As AquaControls.AquaGauge
    Friend WithEvents TextBoxReceiver As System.Windows.Forms.TextBox
    Friend WithEvents Label0000 As System.Windows.Forms.Label
    Friend WithEvents Label0001 As System.Windows.Forms.Label
    Friend WithEvents Panel0000 As System.Windows.Forms.Panel
    Friend WithEvents ButtonDisconnect As System.Windows.Forms.Button
    Friend WithEvents ButtonConnect As System.Windows.Forms.Button
    Friend WithEvents LabelHour As System.Windows.Forms.Label
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents PanelRx As System.Windows.Forms.Panel
    Friend WithEvents PanelTx As System.Windows.Forms.Panel
    Friend WithEvents Label0002 As System.Windows.Forms.Label
    Friend WithEvents Label0003 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSend As System.Windows.Forms.TextBox

End Class
