Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("https://www.paypal.me/Brionjv")
    End Sub

    Private Sub Form3_Click(sender As Object, e As EventArgs) Handles MyBase.Click, Label2.Click
        Me.Close()
    End Sub
End Class