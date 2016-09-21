
Public Class Form_MessageBox

#Region "Form event"

    Public Sub Form_MessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MessageLoad()

    End Sub

    Private Sub Form_MessageBox_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

        FormMouseDown(Me)

    End Sub

    Private Sub Form_MessageBox_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        FormMouseMove(Me)

    End Sub

    Private Sub Form_MessageBox_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp

        FormMouseUp()

    End Sub

#End Region

#Region "Controls"

    Private Sub Button01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button01.Click

        FormMessageBoxButton(1)

    End Sub

    Private Sub Button02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button02.Click

        FormMessageBoxButton(2)

    End Sub

    Private Sub Button03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button03.Click

        FormMessageBoxButton(3)

    End Sub

#End Region

End Class