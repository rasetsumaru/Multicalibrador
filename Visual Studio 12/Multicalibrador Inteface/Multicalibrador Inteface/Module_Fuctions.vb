
#Region "Imports"

Imports System.Text
Imports System.IO.Ports

#End Region

Module Module_Functions

#Region "Statements"

    Public WithEvents _SerialPort As New System.IO.Ports.SerialPort
    Public WithEvents _Seriallist As New System.Windows.Forms.ListBox

    Public WithEvents _TimerNow As New System.Windows.Forms.Timer
    Public WithEvents _TimerConnected As New System.Windows.Forms.Timer
    Public WithEvents _TimerDisconnected As New System.Windows.Forms.Timer
    Public WithEvents _TimerUsartTx As New System.Windows.Forms.Timer
    Public WithEvents _TimerUsartRx As New System.Windows.Forms.Timer

    Public WithEvents _TimerPanelTx As New System.Windows.Forms.Timer
    Public WithEvents _TimerPanelRx As New System.Windows.Forms.Timer

    Public WithEvents _TimerUsartTxController As New System.Windows.Forms.Timer

#End Region

#Region "Form_evetns"

    Public Sub FormMouseDown(_form As System.Windows.Forms.Form)

        drag = True
        mousex = System.Windows.Forms.Cursor.Position.X - _form.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - _form.Top

    End Sub

    Public Sub FormMouseMove(_form As System.Windows.Forms.Form)

        If drag Then
            _form.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            _form.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If


    End Sub

    Public Sub FormMouseUp()

        drag = False

    End Sub

    Public Sub BootControls()

        UsartConnected = False

        With Form_Multicalibrador
            .ButtonDisconnect.Visible = False
            .RadioButton0000.Select()
            .RadioButton0003.Select()
            .TrackBarControl.Enabled = False

        End With

        With _TimerNow
            .Enabled = True
            .Interval = 100
        End With

        With _TimerConnected
            .Enabled = True
            .Interval = 1500
            .Stop()
        End With

        With _TimerDisconnected
            .Enabled = True
            .Interval = 1500
            .Stop()
        End With

        With _TimerUsartTx
            .Enabled = True
            .Interval = 400
            .Stop()
        End With

        With _TimerUsartRx
            .Enabled = True
            .Interval = 400
            .Stop()
        End With

        With _TimerPanelTx
            .Enabled = True
            .Interval = 50
            .Stop()
        End With

        With _TimerPanelRx
            .Enabled = True
            .Interval = 50
            .Stop()
        End With

        With _TimerUsartTxController
            .Enabled = True
            .Interval = 10
            .Stop()
        End With

    End Sub

#End Region

#Region "AquaGauges"

    Public Sub RefreshAquaGaugeControlOutput()

        With Form_Multicalibrador.AquaGaugeControlOutput
            .Value = Form_Multicalibrador.TrackBarControl.Value / 100
            .RecommendedValue = FeedBack
            .ThresholdPercent = 4

        End With

        Form_Multicalibrador.TextBoxSend.Text = Conversion.Int(Form_Multicalibrador.AquaGaugeControlOutput.Value)

    End Sub

#End Region

#Region "Messages"

    Public Sub FormMessageBox(_message As Integer)

        LoadMessage = _message
        If Form_MessageBox.IsHandleCreated = True Then
            MessageLoad()
        Else
            Form_MessageBox.ShowDialog()
        End If

    End Sub

    Public Sub MessageLoad()

        With Form_MessageBox
            .Activate()
            .Visible = True
            .Button01.Visible = False
            .Button02.Visible = False
            .Button03.Visible = False
        End With

        Select Case LoadMessage

            Case Is = 0
                With Form_MessageBox
                    .LabelMessage.Text = "There is a device connected to the software. Do you want to disconnect it?"
                    With .Button01
                        .Visible = True
                        .Text = "No"
                    End With
                    With .Button02
                        .Visible = True
                        .Text = "Yes"
                    End With
                End With

            Case Is = 1
                With Form_MessageBox
                    .LabelMessage.Text = "USB Usart disconnected."
                    With .Button01
                        .Visible = True
                        .Text = "Ok"
                    End With

                End With

            Case Is = 2
                With Form_MessageBox
                    .LabelMessage.Text = "Failure to open the serial port" & " " & _SerialPort.PortName & "." & "Try again?"
                    With .Button01
                        .Visible = True
                        .Text = "No"
                    End With
                    With .Button02
                        .Visible = True
                        .Text = "Yes"
                    End With

                End With

            Case Is = 3
                With Form_MessageBox
                    .LabelMessage.Text = "Device not found."
                    With .Button01
                        .Visible = True
                        .Text = "Ok"
                    End With

                End With

            Case Is = 4
                With Form_MessageBox
                    .LabelMessage.Text = "Communication failure."
                    With .Button01
                        .Visible = True
                        .Text = "Ok"
                    End With
                End With

            Case Is = 5
                With Form_MessageBox
                    .LabelMessage.Text = "USB Usart connected."
                    With .Button01
                        .Visible = True
                        .Text = "Ok"
                    End With
                End With

        End Select

    End Sub

    Public Sub FormMessageBoxButton(_button As Integer)

        Select Case _button

            Case Is = 1
                Select Case LoadMessage

                    Case Is = 0
                        Form_MessageBox.Dispose()

                    Case Is = 1
                        Form_MessageBox.Dispose()

                    Case Is = 2
                        Form_MessageBox.Dispose()
                        SerialPortForceDisconnected()

                    Case Is = 3
                        Form_MessageBox.Dispose()

                    Case Is = 4
                        Form_MessageBox.Dispose()

                    Case Is = 5
                        Form_MessageBox.Dispose()
                        _TimerUsartTxController.Start()

                End Select

            Case Is = 2
                Select Case LoadMessage

                    Case Is = 0
                        Form_MessageBox.Dispose()
                        ConnectDevice()

                    Case Is = 2
                        Form_MessageBox.Dispose()
                        _TimerConnected.Start()

                End Select

            Case Is = 3
                Select Case LoadMessage

                End Select

        End Select

    End Sub

#End Region

#Region "Threading"

    Public Sub _TimerNow_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _TimerNow.Tick

        Form_Multicalibrador.LabelHour.Text = Format(Now, "HH:mm:ss")

    End Sub

    Public Sub _TimerConnected_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _TimerConnected.Tick

        _TimerConnected.Stop()

        If UsartConnected = False Then

            If UsartRxControl < 3 Then
                UsartRxControl += 1
            Else
                UsartRxControl = 0
                UsartPorts += 1
            End If

            If _Seriallist.Items.Count > 0 And UsartPorts <= _Seriallist.Items.Count - 1 Then

                Try

                    _Seriallist.SelectedIndex = UsartPorts
                    SerialPortSetup()

                    With _SerialPort
                        .Open()
                        .Write(vbLf)
                    End With

                    UsartTx = "WC00001"
                    _TimerUsartTx.Start()

                Catch ex As Exception

                    FormMessageBox(2)

                End Try

            Else

                FormMessageBox(3)

                With Form_Multicalibrador
                    .ButtonConnect.Enabled = True
                    .ButtonClose.Enabled = True

                End With

            End If

        End If

    End Sub

    Public Sub _TimerDisconnected_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _TimerDisconnected.Tick

        _TimerDisconnected.Stop()
        SerialPortForceDisconnected()
        FormMessageBox(4)

    End Sub

    Public Sub _TimerUsartTx_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _TimerUsartTx.Tick

        _TimerUsartTx.Stop()

        If UsartConnected = False Then
            SerialPortConnect(UsartTx)
            _TimerConnected.Start()
        Else
            SerialPortDataSend(UsartTx)
        End If

    End Sub

    Public Sub _TimerUsartRx_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _TimerUsartRx.Tick

        _TimerUsartRx.Stop()

        If UsartConnected = True Then

            If UsartRxTimeout < 3 Then
                _TimerUsartTx.Start()
                UsartRxTimeout += 1
            Else
                _TimerDisconnected.Start()
                ConnectDevice()
            End If

        End If

    End Sub

    Public Sub _TimerPanelTx_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _TimerPanelTx.Tick

        _TimerPanelTx.Stop()
        Form_Multicalibrador.PanelTx.BackColor = System.Drawing.Color.Transparent

    End Sub

    Public Sub _TimerPanelRx_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _TimerPanelRx.Tick

        _TimerPanelRx.Stop()
        Form_Multicalibrador.PanelRx.BackColor = System.Drawing.Color.Transparent

    End Sub

    Public Sub _TimerPanelTxController_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _TimerUsartTxController.Tick

        _TimerUsartTxController.Stop()

        UsartTx = "WV000"

        Dim Output As Integer

        Select Case ControlOutput

            Case Is = 0

                Output = (Convert.ToInt32(Form_Multicalibrador.TextBoxSend.Text) * 255) / 1000

            Case Is = 1

                Output = (Convert.ToInt32(Form_Multicalibrador.TextBoxSend.Text) * 255) / 2000

            Case Is = 2

                Output = (Convert.ToInt32(Form_Multicalibrador.TextBoxSend.Text) * 255) / 1050

        End Select

        For i As Integer = 1 To 3 - Output.ToString.Length
            UsartTx += "0"

        Next

        UsartTx += Output.ToString
        SerialPortDataSend(UsartTx)

    End Sub

#End Region

#Region "SerialPort controller"

    Public Sub ConnectDevice()

        UsartRxControl = 0
        UsartRxTimeout = 0

        If UsartConnected = False Then

            UsartPorts = 0
            SerialPortGetNames()
            _TimerConnected.Start()

            With Form_Multicalibrador
                .ButtonConnect.Enabled = False
                .ButtonClose.Enabled = False

            End With

        Else

            _TimerUsartTxController.Stop()
            UsartTx = "WC00000"
            _TimerUsartTx.Start()
            Form_Multicalibrador.ButtonConnect.Enabled = False

        End If

    End Sub

    Public Sub SerialPortForceDisconnected()

        _TimerConnected.Stop()
        _TimerUsartTx.Stop()
        _TimerUsartRx.Stop()

        UsartConnected = False

        UsartRx = ""

        With Form_Multicalibrador

            .ButtonConnect.Visible = True
            .ButtonConnect.Enabled = True
            .ButtonDisconnect.Visible = False
            .TrackBarControl.Enabled = False

        End With

        RemoveHandler _SerialPort.DataReceived, AddressOf Form_Multicalibrador.DataReceivedHandler
        Application.DoEvents()

        If _SerialPort.IsOpen Then
            With _SerialPort
                .DiscardInBuffer()
                .DiscardOutBuffer()
                .Close()
                .Dispose()
            End With
        End If

        _Seriallist.Items.Clear()

    End Sub

    Public Sub SerialPortGetNames()

        _Seriallist.Items.Clear()

        For Each portname As String In My.Computer.Ports.SerialPortNames
            _Seriallist.Items.Add(portname)
        Next

    End Sub

    Public Sub SerialPortSetup()

        RemoveHandler _SerialPort.DataReceived, AddressOf Form_Multicalibrador.DataReceivedHandler
        Application.DoEvents()

        If _SerialPort.IsOpen Then
            With _SerialPort
                .DiscardInBuffer()
                .DiscardOutBuffer()
                .Close()
                .Dispose()
            End With
        End If

        With _SerialPort
            .PortName = _Seriallist.SelectedItem
            .BaudRate = 115200
            .DataBits = 8
            .Parity = Parity.None
            .StopBits = StopBits.One
            .Handshake = Handshake.None
            .Encoding = System.Text.Encoding.Default
            .RtsEnable = False
            AddHandler _SerialPort.DataReceived, AddressOf Form_Multicalibrador.DataReceivedHandler

        End With

    End Sub

    Public Sub SerialPortConnect(SerialData As String)

        Form_Multicalibrador.PanelTx.BackColor = System.Drawing.SystemColors.ControlDark
        _SerialPort.Write(SerialData + vbLf)
        _TimerPanelTx.Start()

    End Sub

    Public Sub SerialPortDataSend(SerialData As String)

        If SerialData.Length < 69 Then
            For i As Byte = 0 To 69 - SerialData.Length - 1
                SerialData += " "
            Next
        End If

        Dim array() As Byte = System.Text.Encoding.ASCII.GetBytes(SerialData)

        Dim checksum As Long
        Dim datacalculations As Long
        Dim checksumstring As String = ""

        For i As Byte = 0 To SerialData.Length - 1
            datacalculations = array(i) * (i + 1)
            checksum += datacalculations
        Next

        checksum = checksum Mod 99

        For i As Byte = 0 To 3 - checksum.ToString.Length - 1
            checksumstring += "0"
        Next

        checksumstring += checksum.ToString

        Form_Multicalibrador.PanelTx.BackColor = System.Drawing.SystemColors.ControlDark
        _SerialPort.Write("@" + SerialData + "%" + checksumstring + "#" + vbLf)
        _TimerPanelTx.Start()
        _TimerUsartRx.Start()

    End Sub

    Public Sub SerialRead()

        Dim SerialData As String
        Dim SerialChecksum As Integer

        _TimerUsartRx.Stop()
        _TimerPanelRx.Start()

        With Form_Multicalibrador
            .TextBoxReceiver.Text = UsartRx
            .PanelRx.BackColor = System.Drawing.SystemColors.ControlDark
        End With

        UsartRxTimeout = 0

        If Strings.Left(UsartRx, 1) = "@" And Strings.Right(UsartRx, 1) = "#" Then

            UsartRx = UsartRx.Substring(1, UsartRx.Length - 2)

            SerialData = UsartRx.Substring(0, UsartRx.IndexOf("%"))
            SerialChecksum = Strings.Right(UsartRx, 3)

            Dim array() As Byte = System.Text.Encoding.ASCII.GetBytes(SerialData)

            Dim checksum As Long
            Dim datacalculations As Long

            For i As Byte = 0 To SerialData.Length - 1
                datacalculations = array(i) * (i + 1)
                checksum += datacalculations
            Next

            checksum = checksum Mod 99

            If checksum = Convert.ToInt32(SerialChecksum) Then
                UsartRxControl = 0
                SerialDecoder(SerialData)
            Else
                If UsartRxControl < 3 Then
                    _TimerUsartTx.Start()
                    UsartRxControl = UsartRxControl + 1
                Else
                    _TimerDisconnected.Start()
                    ConnectDevice()
                End If

            End If

        End If

    End Sub

    Public Sub SerialDecoder(Decoder As String)

        Dim Header As String = Decoder.Substring(0, 2)
        Dim Control As String = Decoder.Substring(2, 3)
        Dim Data As String = Decoder.Substring(5, 64)

        If Header.Equals("RC") Then

            If Control.Equals("000") Then
                If Data.Substring(0, 2) = "01" Then
                    UsartConnected = True
                    UsartRx = ""

                    _TimerConnected.Stop()

                    With Form_Multicalibrador
                        .ButtonConnect.Visible = False
                        .ButtonDisconnect.Visible = True
                        .TrackBarControl.Enabled = True

                    End With

                    FormMessageBox(5)

                    Exit Sub
                End If

                If Data.Substring(0, 2) = "00" Then
                    UsartConnected = False

                    UsartRx = ""

                    RemoveHandler _SerialPort.DataReceived, AddressOf Form_Multicalibrador.DataReceivedHandler
                    Application.DoEvents()

                    If _SerialPort.IsOpen Then
                        With _SerialPort
                            .DiscardInBuffer()
                            .DiscardOutBuffer()
                            .Close()
                            .Dispose()
                        End With
                    End If

                    With Form_Multicalibrador
                        .ButtonConnect.Visible = True
                        .ButtonConnect.Enabled = True
                        .ButtonDisconnect.Visible = False
                        .ButtonClose.Enabled = True
                        .TrackBarControl.Enabled = False

                    End With

                    _TimerDisconnected.Stop()
                    _TimerConnected.Stop()
                    _TimerUsartTx.Stop()
                    _TimerUsartRx.Stop()

                    FormMessageBox(1)

                    Exit Sub

                End If

            End If

        End If

        If Header.Equals("RV") Then
            If Control.Equals("000") Then

                UsartRx = ""

                Dim FeedControl() As Integer = {1000, 500, 950}

                FeedBack = (Convert.ToInt32(Data.Substring(0, 4)) * 1023) / FeedControl(ControlOutput)
                AnalogVin = (Convert.ToInt32(Data.Substring(4, 4)) * 1023) / 1000
                AnalogIin = (Convert.ToInt32(Data.Substring(8, 4)) * 1023) / 2000
                AnalogJin = (Convert.ToInt32(Data.Substring(12, 4)) * 1023) / 1050

                With Form_Multicalibrador.AquaGaugeControlOutput
                    .RecommendedValue = FeedBack
                    .ThresholdPercent = 3

                End With

                Dim Input() As Integer = {AnalogVin, AnalogIin, AnalogJin}

                With Form_Multicalibrador.AquaGaugeControlInput
                    .Value = Input(ControlInput)
                    .RecommendedValue = 0.01
                    .ThresholdPercent = 0.01

                End With

                _TimerUsartTxController.Start()

            End If

            Exit Sub
        End If

    End Sub

#End Region

End Module
