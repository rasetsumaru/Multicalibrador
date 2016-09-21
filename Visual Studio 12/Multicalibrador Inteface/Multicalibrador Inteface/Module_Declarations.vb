
Module Module_Declarations

#Region "Usart communication"

    Public UsartRx As String
    Public UsartTx As String
    Public UsartConnected As Boolean
    Public UsartPorts As Integer

    Public UsartRxControl As Integer
    Public UsartRxTimeout As Integer

    Public ControlInput As Integer
    Public ControlOutput As Integer

    Public FeedBack As Integer
    Public AnalogVin As Integer
    Public AnalogIin As Integer
    Public AnalogJin As Integer

#End Region

#Region "Forms"

    Public drag As Boolean
    Public mousex As Integer
    Public mousey As Integer

#End Region

#Region "Messages"

    Public LoadMessage As Integer

#End Region

End Module
