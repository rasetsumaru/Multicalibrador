
Public Class Form_Multicalibrador

#Region "Form event"

    Private Sub Form_Multicalibrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BootControls()

    End Sub

    Private Sub Form_Multicalibrador_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If UsartConnected = True Then
            e.Cancel = True
            FormMessageBox(0)
        End If

    End Sub

    Private Sub Form_Multicalibrador_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

        FormMouseDown(Me)

    End Sub

    Private Sub Form_Multicalibrador_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        FormMouseMove(Me)

    End Sub

    Private Sub Form_Multicalibrador_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp

        FormMouseUp()

    End Sub

#End Region

#Region "Controls"

    Private Sub TrackBarControl_Scroll(sender As Object, e As EventArgs) Handles TrackBarControl.Scroll

        RefreshAquaGaugeControlOutput()

    End Sub

    Private Sub RadiosInput(sender As Object, e As EventArgs) Handles RadioButton0000.Click, RadioButton0001.Click, RadioButton0002.Click
        Dim rb As RadioButton
        rb = sender

        ControlInput = Convert.ToInt32(Strings.Right(rb.Name, 4))

        Select Case ControlInput

            Case Is = 0
                With AquaGaugeControlInput
                    .DialText = "mVolts"
                    .MinValue = 0
                    .MaxValue = 1000
                    .NoOfDivisions = 10
                    .NoOfSubDivisions = 10
                    .RecommendedValue = 0.01
                    .ThresholdPercent = 0.01

                End With

            Case Is = 1
                With AquaGaugeControlInput
                    .DialText = "uAmper"
                    .MinValue = 0
                    .MaxValue = 2000
                    .NoOfDivisions = 10
                    .NoOfSubDivisions = 10
                    .RecommendedValue = 0.01
                    .ThresholdPercent = 0.01

                End With

            Case Is = 2
                With AquaGaugeControlInput
                    .DialText = "TypeJ"
                    .MinValue = 0
                    .MaxValue = 1050
                    .NoOfDivisions = 10
                    .NoOfSubDivisions = 10
                    .RecommendedValue = 0.01
                    .ThresholdPercent = 0.01

                End With

        End Select

    End Sub

    Private Sub RadiosOutput(sender As Object, e As EventArgs) Handles RadioButton0003.Click, RadioButton0004.Click, RadioButton0005.Click
        Dim rb As RadioButton
        rb = sender

        ControlOutput = Convert.ToInt32(Strings.Right(rb.Name, 4)) - 3

        Select Case ControlOutput

            Case Is = 0
                With AquaGaugeControlOutput
                    .DialText = "mVolts"
                    .MinValue = 0
                    .MaxValue = 1000
                    .NoOfDivisions = 10
                    .NoOfSubDivisions = 10
                    .RecommendedValue = 0.01
                    .ThresholdPercent = 4

                End With

                With TrackBarControl
                    .Maximum = 100000
                    .Minimum = 0
                    .TickFrequency = 10000
                    .SmallChange = 100
                    .LargeChange = 1000

                End With

            Case Is = 1
                With AquaGaugeControlOutput
                    .DialText = "uAmper"
                    .MinValue = 0
                    .MaxValue = 2000
                    .NoOfDivisions = 10
                    .NoOfSubDivisions = 10
                    .RecommendedValue = 0.01
                    .ThresholdPercent = 4

                End With

                With TrackBarControl
                    .Maximum = 200000
                    .Minimum = 0
                    .TickFrequency = 20000
                    .SmallChange = 100
                    .LargeChange = 1000

                End With

            Case Is = 2
                With AquaGaugeControlOutput
                    .DialText = "TypeJ"
                    .MinValue = 0
                    .MaxValue = 1050
                    .NoOfDivisions = 10
                    .NoOfSubDivisions = 10
                    .RecommendedValue = 0.01
                    .ThresholdPercent = 4

                End With

                With TrackBarControl
                    .Maximum = 105000
                    .Minimum = 0
                    .TickFrequency = 10500
                    .SmallChange = 100
                    .LargeChange = 1000

                End With

        End Select

        TrackBarControl.Value = 0
        RefreshAquaGaugeControlOutput()

    End Sub

#End Region

#Region "Buttons"

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        Close()

    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click

        ConnectDevice()

    End Sub

    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click

        ConnectDevice()

    End Sub

#End Region

#Region "Usart DataReceived"

    Public Sub DataReceivedHandler(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs)

        If _SerialPort.IsOpen Then
            UsartRx = _SerialPort.ReadTo(vbLf)
            If UsartRx.Length > 0 Then
                UsartRx = UsartRx.Replace(vbLf, "")
                BeginInvoke(New Threading.ThreadStart(AddressOf SerialRead))
            End If
        End If

    End Sub

#End Region

End Class

