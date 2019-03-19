Public Class Disclaimer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oForm As UserInputModule
        oForm = New UserInputModule()
        oForm.Show()
        Me.Close()
    End Sub
End Class